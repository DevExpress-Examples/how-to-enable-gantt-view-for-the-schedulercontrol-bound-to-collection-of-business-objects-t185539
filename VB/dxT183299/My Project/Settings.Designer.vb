﻿' Developer Express Code Central Example:
' How to enable Gantt view for the SchedulerControl bound to collection of business objects
' 
' This is a simple example of XtraScheduler bound to collection of custom business
' objects (https://documentation.devexpress.com/#WindowsForms/CustomDocument9606)
' displaying Gantt view
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10698). This
' project also utilizes the ResourcesTree control
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10685) to
' display a hierarchy of resources and the SplitContainer control
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSplitContainerControltopic)
' to allow resizing of Scheduler and ResourceTree controls.
' 
' To accomplish this
' task, you should have three collections - for appointments, for resources and
' for appointments dependencies. All collections should implement the IBindingList
' interface. You can implement this interface manually in your custom collection,
' but we recommend you use the System.ComponentModel.BindingList<T>
' collection.
' 
' Additionally, your business objects should have properties
' suitable for mapping
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument15468)to the
' corresponding properties of XtraScheduler appointments, resources and
' appointments dependencies.
' 
' See
' also:
' http://www.devexpress.com/scid=E750
' http://www.devexpress.com/scid=E3574
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T185539

' Developer Express Code Central Example:
' How to enable Gantt view for the SchedulerControl bound to collection of business objects
' 
' This is a simple example of XtraScheduler bound to collection of custom business
' objects (https://documentation.devexpress.com/#WindowsForms/CustomDocument9606)
' displaying Gantt view
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10698). This
' project also utilizes the ResourcesTree control
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10685) to
' display a hierarchy of resources and the SplitContainer control
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSplitContainerControltopic)
' to allow resizing of Scheduler and ResourceTree controls.
' 
' To accomplish this
' task, you should have three collections - for appointments, for resources and
' for appointments dependencies. All collections should implement the IBindingList
' interface. You can implement this interface manually in your custom collection,
' but we recommend you use the System.ComponentModel.BindingList<T>
' collection.
' 
' Additionally, your business objects should have properties
' suitable for mapping
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument15468)to the
' corresponding properties of XtraScheduler appointments, resources and
' appointments dependencies.
' 
' See
' also:
' http://www.devexpress.com/scid=E750
' http://www.devexpress.com/scid=E3574
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T185539

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34011
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
