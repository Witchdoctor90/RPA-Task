using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using RPATask;
using System.Data;
using UiPath.Core.Activities;
using UiPath.Testing;
using UiPath.Testing.Activities;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.UIAutomationNext.Activities;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.API;
using UiPath.UIAutomationNext.Models;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.GSuite.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;

[assembly: WorkflowRunnerServiceAttribute(typeof(RPATask.WorkflowRunnerService))]
namespace RPATask
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the DownloadEmailAttachment.cs
        /// </summary>
        public void DownloadEmailAttachment()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DownloadEmailAttachment.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}