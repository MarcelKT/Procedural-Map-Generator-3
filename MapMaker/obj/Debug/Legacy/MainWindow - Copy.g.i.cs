#pragma checksum "..\..\..\Legacy\MainWindow - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C55957773D7B9CEBDB9C3C2145B04821F46DBFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MapMaker;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MapMaker {


	/// <summary>
	/// MainWindow
	/// </summary>
	public partial class MainWindow_Legacy : System.Windows.Window, System.Windows.Markup.IComponentConnector {


#line 11 "..\..\..\Legacy\MainWindow - Copy.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Image mapDisplay;

#line default
#line hidden

		private bool _contentLoaded;

		/// <summary>
		/// InitializeComponent
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent() {
			if (_contentLoaded) {
				return;
			}
			_contentLoaded = true;
			System.Uri resourceLocater = new System.Uri("/MapMaker;component/legacy/mainwindow%20-%20copy.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Legacy\MainWindow - Copy.xaml"
			System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
			switch (connectionId) {
				case 1:

#line 8 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((MapMaker.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);

#line default
#line hidden
					return;
				case 2:
					this.mapDisplay = ((System.Windows.Controls.Image)(target));
					return;
				case 3:

#line 12 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonRegenerate);

#line default
#line hidden
					return;
				case 4:

#line 15 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowLandscape);

#line default
#line hidden
					return;
				case 5:

#line 16 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowBiomes);

#line default
#line hidden
					return;
				case 6:

#line 19 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeightGlobalVariance);

#line default
#line hidden
					return;
				case 7:

#line 20 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeightBase);

#line default
#line hidden
					return;
				case 8:

#line 21 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeightNoise);

#line default
#line hidden
					return;
				case 9:

#line 22 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeightMerged);

#line default
#line hidden
					return;
				case 10:

#line 23 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeightEroded);

#line default
#line hidden
					return;
				case 11:

#line 26 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeatLatitude);

#line default
#line hidden
					return;
				case 12:

#line 27 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeatNoise);

#line default
#line hidden
					return;
				case 13:

#line 28 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeatMerged);

#line default
#line hidden
					return;
				case 14:

#line 29 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHeatSectioned);

#line default
#line hidden
					return;
				case 15:

#line 32 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHumidityGlobalVariance);

#line default
#line hidden
					return;
				case 16:

#line 33 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHumidityNoise);

#line default
#line hidden
					return;
				case 17:

#line 34 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHumidityMerged);

#line default
#line hidden
					return;
				case 18:

#line 35 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonShowHumiditySectioned);

#line default
#line hidden
					return;
				case 19:

#line 37 "..\..\..\Legacy\MainWindow - Copy.xaml"
					((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonSave);

#line default
#line hidden
					return;
			}
			this._contentLoaded = true;
		}
	}
}

