# cppt
Cross-Platform PT with Microsoft.NET Core

All development of this application is being done on Microsoft Visual Studio Code running on various 
Ubuntu Linux 14.04 installs with .NET Core RC2 using .NET Core Launch (Console) for debugging.  The application will
be a test harness for data and the main UI will be created once the Windows.UI XAML components are available
for cross-platform light-weight MVVM patterns.

Data stores will be directly with MySQL and/or Tomcat Java Servlets running on various Ubuntu 12.04 servers. 

Builds for cppt.dll will be periodically tested on the following platforms:

Ubuntu Linux 14.04 (primary platform)
Chrome OS (primary platform after Ubuntu development complete)
Windows 10 64-Bit (1511 release and forward for secondary platform)
OS/X 10.9 (and new Mac OS when available on tri platform)

Project folder structure in place for base WPF compiles using the MVVM pattern in Visual Studio Code for View and 
ViewModel once the binding engine port on base controls (i.e. Window, UcerControl, Grid, TextBox, 
ComboBox, Label) has been completed if it will be available in the Windows.UI namespace.