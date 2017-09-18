------------------------------
 MDI CONTAINER DEMO
 by Francesco Balena
------------------------------

This sample applications show how you can write "generic" MDI parent forms that communicate with their child forms using user-defined interfaces rather than by directly manipulating the controls on the MDI child forms. This approach requires more code, but it keeps the parent and the child forms completely distinct. This implies that you can write a new application by simply writing a new type of child form, without having to modify a single line of code in the MDI parent form.

To run this demo, load the MDIDemo.VBG project group and make MDIDemo1.vbp the startup project. In this demo the MDI parent form hosts a MDI child form that includes a text editor. Then make MDIDemo2.vbp the startup project, and you will see that the same MDI parent form this time hosts a child form that works as a picture viewer. Since the two communicate through an interface, it wasn't necessary to modify the parent.

Finally, make MDIDemo3.vbp the startup form, and see how - with minor modifications to the parent MDI form - it is possibile to have the same MDI form to act as a container for different child forms in the same application.

Note that the "interface" used in this example is actually only a convention between the parent and the child forms, and is based on late binding. This example can be greately improved by defining an actual interface (say, IMDIChild) and make each child form implement it.

