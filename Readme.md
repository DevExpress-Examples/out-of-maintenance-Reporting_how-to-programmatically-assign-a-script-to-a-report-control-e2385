# How to programmatically assign a script to a report control


<p>The following example demonstrates how to add a script to a report control at runtime.</p>


<h3>Description</h3>

<p>To accomplish this task, it is first necessary to add required code to the collection of all scripts, stored in the <strong>XtraReport.ScriptsSource</strong> property. Then, assign the name of the script to the control&#39;s <strong>XRControl.Scripts.OnBeforePrint</strong> property, and this will result in executing this code when an appropriate even is raised by the report generation engine.</p>

<br/>


