using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitWPFAddinTemplate.TemplatePlugin.ViewModels;
using RevitWPFAddinTemplate.TemplatePlugin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitWPFAddinTemplate.TemplatePlugin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        static AddInId AddInId = new AddInId(new Guid("B217F617-9B59-4DD2-AF4B-07612BEFA56A"));
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var viewModel = new TemplatePluginViewModel();
            var view = new TemplatePluginView(viewModel);
            viewModel.CloseRequest += (s, e) => view.Close();
            viewModel.HideRequest += (s, e) => view.Hide();
            viewModel.ShowRequest += (s, e) => view.ShowDialog();
            view.ShowDialog();
            return Result.Succeeded;
        }
    }
}
