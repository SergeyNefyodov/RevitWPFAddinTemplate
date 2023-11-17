using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RevitWPFAddinTemplate
{
    public class Application : IExternalApplication
    {
        static readonly AddInId addInId = new AddInId(new Guid("9A49449A-9EB2-4AA1-8423-128F86AAF5DD"));
        private readonly string assemblyPath = Assembly.GetExecutingAssembly().Location;
        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Revit Application";
            application.CreateRibbonTab(tabName);
            RibbonPanel ribbonPanel = application.CreateRibbonPanel(tabName, "Revit Panel");
            AddPushButton(ribbonPanel, "Template Plugin", assemblyPath, "RevitWPFAddinTemplate.TemplatePlugin.Command", "Tool tip");
            
            return Result.Succeeded;
        }

        private void AddPushButton(RibbonPanel ribbonPanel, string buttonName, string path, string linkToCommand, string toolTip)
        {
            var buttonData = new PushButtonData(buttonName, buttonName, path, linkToCommand);
            var button = ribbonPanel.AddItem(buttonData) as PushButton;
            button.ToolTip = toolTip;
            button.LargeImage = (ImageSource)new BitmapImage(new Uri(@"/RevitWPFAddinTemplate;component/Resources/engineer2.png", UriKind.RelativeOrAbsolute));
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
