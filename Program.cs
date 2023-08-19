// See https://aka.ms/new-console-template for more information

using CSharp_Exercises;

var workflowEngine = new WorkflowEngine();

workflowEngine.Run(new UploadVideoToCloud());
workflowEngine.Run(new InformWebService());
workflowEngine.Run(new SendMailToOwner());
workflowEngine.Run(new ChangeVideoStatus());




