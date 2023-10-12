// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/todo.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ToDoGrpc {
  public static partial class ToDo
  {
    static readonly string __ServiceName = "todo.ToDo";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.CreateToDoRequest> __Marshaller_todo_CreateToDoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.CreateToDoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.CreateToDoResponse> __Marshaller_todo_CreateToDoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.CreateToDoResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.ReadToDoRequest> __Marshaller_todo_ReadToDoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.ReadToDoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.ReadToDoResponse> __Marshaller_todo_ReadToDoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.ReadToDoResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.GetAllRequest> __Marshaller_todo_GetAllRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.GetAllRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.GetAllResponse> __Marshaller_todo_GetAllResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.GetAllResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.UpdateToDoRequest> __Marshaller_todo_UpdateToDoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.UpdateToDoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.UpdateToDoResponse> __Marshaller_todo_UpdateToDoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.UpdateToDoResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.DeleteToDoRequest> __Marshaller_todo_DeleteToDoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.DeleteToDoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ToDoGrpc.DeleteToDoResponse> __Marshaller_todo_DeleteToDoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ToDoGrpc.DeleteToDoResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ToDoGrpc.CreateToDoRequest, global::ToDoGrpc.CreateToDoResponse> __Method_CreateToDo = new grpc::Method<global::ToDoGrpc.CreateToDoRequest, global::ToDoGrpc.CreateToDoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateToDo",
        __Marshaller_todo_CreateToDoRequest,
        __Marshaller_todo_CreateToDoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ToDoGrpc.ReadToDoRequest, global::ToDoGrpc.ReadToDoResponse> __Method_ReadToDo = new grpc::Method<global::ToDoGrpc.ReadToDoRequest, global::ToDoGrpc.ReadToDoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadToDo",
        __Marshaller_todo_ReadToDoRequest,
        __Marshaller_todo_ReadToDoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ToDoGrpc.GetAllRequest, global::ToDoGrpc.GetAllResponse> __Method_ListToDo = new grpc::Method<global::ToDoGrpc.GetAllRequest, global::ToDoGrpc.GetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListToDo",
        __Marshaller_todo_GetAllRequest,
        __Marshaller_todo_GetAllResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ToDoGrpc.UpdateToDoRequest, global::ToDoGrpc.UpdateToDoResponse> __Method_UpdateToDo = new grpc::Method<global::ToDoGrpc.UpdateToDoRequest, global::ToDoGrpc.UpdateToDoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateToDo",
        __Marshaller_todo_UpdateToDoRequest,
        __Marshaller_todo_UpdateToDoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ToDoGrpc.DeleteToDoRequest, global::ToDoGrpc.DeleteToDoResponse> __Method_DeleteToDo = new grpc::Method<global::ToDoGrpc.DeleteToDoRequest, global::ToDoGrpc.DeleteToDoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteToDo",
        __Marshaller_todo_DeleteToDoRequest,
        __Marshaller_todo_DeleteToDoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ToDoGrpc.TodoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ToDo</summary>
    [grpc::BindServiceMethod(typeof(ToDo), "BindService")]
    public abstract partial class ToDoBase
    {
      /// <summary>
      /// create
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ToDoGrpc.CreateToDoResponse> CreateToDo(global::ToDoGrpc.CreateToDoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// read-single
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ToDoGrpc.ReadToDoResponse> ReadToDo(global::ToDoGrpc.ReadToDoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// read-list
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ToDoGrpc.GetAllResponse> ListToDo(global::ToDoGrpc.GetAllRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// update
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ToDoGrpc.UpdateToDoResponse> UpdateToDo(global::ToDoGrpc.UpdateToDoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// delete
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ToDoGrpc.DeleteToDoResponse> DeleteToDo(global::ToDoGrpc.DeleteToDoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ToDoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateToDo, serviceImpl.CreateToDo)
          .AddMethod(__Method_ReadToDo, serviceImpl.ReadToDo)
          .AddMethod(__Method_ListToDo, serviceImpl.ListToDo)
          .AddMethod(__Method_UpdateToDo, serviceImpl.UpdateToDo)
          .AddMethod(__Method_DeleteToDo, serviceImpl.DeleteToDo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ToDoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ToDoGrpc.CreateToDoRequest, global::ToDoGrpc.CreateToDoResponse>(serviceImpl.CreateToDo));
      serviceBinder.AddMethod(__Method_ReadToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ToDoGrpc.ReadToDoRequest, global::ToDoGrpc.ReadToDoResponse>(serviceImpl.ReadToDo));
      serviceBinder.AddMethod(__Method_ListToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ToDoGrpc.GetAllRequest, global::ToDoGrpc.GetAllResponse>(serviceImpl.ListToDo));
      serviceBinder.AddMethod(__Method_UpdateToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ToDoGrpc.UpdateToDoRequest, global::ToDoGrpc.UpdateToDoResponse>(serviceImpl.UpdateToDo));
      serviceBinder.AddMethod(__Method_DeleteToDo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ToDoGrpc.DeleteToDoRequest, global::ToDoGrpc.DeleteToDoResponse>(serviceImpl.DeleteToDo));
    }

  }
}
#endregion
