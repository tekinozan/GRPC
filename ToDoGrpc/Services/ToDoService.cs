using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoGrpc;

public class ToDoService : ToDo.ToDoBase {
    private readonly AppDbContext _dbContext;

    public ToDoService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<CreateToDoResponse> CreateToDo(CreateToDoRequest request, ServerCallContext context){
        if(request.Title == string.Empty || request.Description == string.Empty){
            throw new RpcException(new Status(StatusCode.InvalidArgument,"You must supply a valid object"));
        }

        var toDoItem = new ToDoItem{
            Title = request.Title,
            Description = request.Description
        };

        await _dbContext.AddAsync(toDoItem);
        await _dbContext.SaveChangesAsync();

        return await Task.FromResult(new CreateToDoResponse{
            Id = toDoItem.Id
        });
    }

    public override async Task<ReadToDoResponse> ReadToDo(ReadToDoRequest request, ServerCallContext context){
        if (request.Id <= 0)
            throw new RpcException(new Status(StatusCode.InvalidArgument, "Id must be greater than 0"));

        var toDoItem = await _dbContext.ToDoItems.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (toDoItem != null)
        {
            return await Task.FromResult(new ReadToDoResponse{
                Id = toDoItem.Id,
                Title = toDoItem.Title,
                Description = toDoItem.Description,
                Status = toDoItem.Status
            });
        }

        throw new RpcException(new Status(StatusCode.NotFound, $"No Task with id {request.Id}"));
    }

    public override async Task<GetAllResponse> ListToDo(GetAllRequest request, ServerCallContext context){
        var response = new GetAllResponse();

        var toDoItems = await _dbContext.ToDoItems.ToListAsync();

        foreach (var toDoItem in toDoItems)
        {
            response.Response.Add(new ReadToDoResponse{
                Id = toDoItem.Id,
                Title = toDoItem.Title,
                Description = toDoItem.Description,
                Status = toDoItem.Status
            });
        }

        return await Task.FromResult(response);
    }

    public override async Task<UpdateToDoResponse> UpdateToDo(UpdateToDoRequest request, ServerCallContext context){

        if (request.Id <= 0 || request.Title == string.Empty || request.Description == string.Empty)
            throw new RpcException(new Status(StatusCode.InvalidArgument, "Id must be greater than 0"));

        var existing = await _dbContext.ToDoItems.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (existing == null)
            throw new RpcException(new Status(StatusCode.NotFound, $"No Task with id {request.Id}"));

        existing.Title = request.Title;
        existing.Description = request.Description;
        existing.Status = request.Status;

        await _dbContext.SaveChangesAsync();    

        return await Task.FromResult(new UpdateToDoResponse{
             Id = existing.Id,
        });
    }

    public override async Task<DeleteToDoResponse> DeleteToDo(DeleteToDoRequest request, ServerCallContext context){

        if (request.Id <= 0)
            throw new RpcException(new Status(StatusCode.InvalidArgument, "Id must be greater than 0"));
        
        var existing = await _dbContext.ToDoItems.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (existing == null)
            throw new RpcException(new Status(StatusCode.NotFound, $"No Task with id {request.Id}"));
            
         _dbContext.ToDoItems.Remove(existing);
         await _dbContext.SaveChangesAsync();

         return await Task.FromResult(new DeleteToDoResponse{
            Id = existing.Id
         });
        

    }
}