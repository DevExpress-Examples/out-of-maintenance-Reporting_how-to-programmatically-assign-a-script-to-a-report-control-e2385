<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602535/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2385)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to programmatically assign a script to a report control


<p>The following example demonstrates how to add a script to a report control at runtime.</p>


<h3>Description</h3>

<p>To accomplish this task, it is first necessary to add required code to the collection of all scripts, stored in the <strong>XtraReport.ScriptsSource</strong> property. Then, assign the name of the script to the control&#39;s <strong>XRControl.Scripts.OnBeforePrint</strong> property, and this will result in executing this code when an appropriate even is raised by the report generation engine.</p>

<br/>


