using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

[assembly: ComVisible(false)]

[assembly: CLSCompliant(true)]

// -----  Legacy -----
[assembly: XmlnsDefinition("http://www.codeplex.com/General", "General.Regions")]
[assembly: XmlnsDefinition("http://www.codeplex.com/General", "General.Regions.Behaviors")]
[assembly: XmlnsDefinition("http://www.codeplex.com/General", "General.Mvvm")]
[assembly: XmlnsDefinition("http://www.codeplex.com/General", "General.Interactivity")]
// -----  Legacy -----

[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Regions")]
[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Regions.Behaviors")]
[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Mvvm")]
[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Interactivity")]
[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Services.Dialogs")]
[assembly: XmlnsDefinition("http://Generallibrary.com/", "General.Ioc")]

