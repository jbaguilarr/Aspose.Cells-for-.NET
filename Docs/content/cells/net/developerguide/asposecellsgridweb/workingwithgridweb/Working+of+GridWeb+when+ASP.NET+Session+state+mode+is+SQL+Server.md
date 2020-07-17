+++
title = "Working of GridWeb when ASP.NET Session state mode is SQL Server" 
description = "" 
weight = 16675 
+++

Aspose.Cells for .NET : Working of GridWeb when ASP.NET Session state mode is SQL Server  

# Aspose.Cells for .NET : Working of GridWeb when ASP.NET Session state mode is SQL Server


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738158842 {padding: 0px;}div.rbtoc1590738158842 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738158842 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios](#WorkingofGridWebwhenASP.NETSessionstatemodeisSQLServer-PossibleUsageScenarios)
*   2 [Working of GridWeb when ASP.NET Session state mode is SQL Server](#WorkingofGridWebwhenASP.NETSessionstatemodeisSQLServer-WorkingofGridWebwhenASP.NETSessionstatemodeisSQLServer)
*   3 [Sample Web.Config Session State Settings](#WorkingofGridWebwhenASP.NETSessionstatemodeisSQLServer-SampleWeb.ConfigSessionStateSettings)
*   4 [Reference Article](#WorkingofGridWebwhenASP.NETSessionstatemodeisSQLServer-ReferenceArticle)

 

## Possible Usage Scenarios

This article explains working of GridWeb when ASP.NET Session state mode is SQL Server.

## Working of GridWeb when ASP.NET Session state mode is SQL Server

If you want to use `SQL Server` or `StateServer` to hold sessions, use `GridWeb Session Mode`. The GridWeb control now supports serializing its data to SQL Server or StateServer.

You will set the `GridWeb.SessionMode` to `SessionMode.Session` and use the following sample `Web.Config` settings. Please change the `sessionState` attributes as per your needs.

## Sample Web.Config Session State Settings

<sessionState mode="SQLServer" sqlConnectionString="Password=11111111;Persist Security Info=True;User ID=testuser;Data Source=WINSHA-PC\\NASIRSQL" timeout="20"></sessionState>

## Reference Article

*   [Enable Different GridWeb Modes](http://localhost:1313/cellsnet/developerguide/asposecellsgridweb/workingwithgridweb/enable+different+gridweb+modes)
