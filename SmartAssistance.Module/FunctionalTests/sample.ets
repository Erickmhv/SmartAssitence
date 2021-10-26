;#DropDB SmartAssistanceEasyTest

#Application SmartAssistance.Win
#Application SmartAssistance.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef SmartAssistance.Win

*Action About...
 
*Action OK

#EndIf

#IfDef SmartAssistance.Web
*Action Navigation(My Details)
#EndIf
