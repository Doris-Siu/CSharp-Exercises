// See https://aka.ms/new-console-template for more information

using CSharp_Exercises;

//var workflowEngine = new WorkflowEngine();

//workflowEngine.Run(new UploadVideoToCloud());
//workflowEngine.Run(new InformWebService());
//workflowEngine.Run(new SendMailToOwner());
//workflowEngine.Run(new ChangeVideoStatus());


var workflow = new Workflow();
workflow.Add(new UploadVideoToCloud());
workflow.Add(new InformWebService());
workflow.Add(new SendMailToOwner());
workflow.Add(new ChangeVideoStatus());

var engine = new WorkflowEngine();
engine.Run(workflow);




