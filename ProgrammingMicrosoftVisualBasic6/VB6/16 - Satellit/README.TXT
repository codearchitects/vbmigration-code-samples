---------------------------------------
 SATELLITE DLLS DEMO
 by Francesco Balena
---------------------------------------

Traditionally, VB programmers use Resource Files when they plan to localize their apps to foreign languages, or heavily customize them for different customers. However, Resource Files require that you recompile your app whenever you need to add support for a new language, and above all cannot switched at runtime. All such problems are solved by using the so-called satellite DLLs.

The idea is very simple: whenever you application needs a string, a picture or any other type of data (including binary data, AVIs, etc.) it invokes a method in the DLL. A default DLL - named MyApplication000.DLL in this sample application - exposes all the resources used by the US version of the software. Then you can build any number of other DLLs for the resources in all other languages (MyApplication410.DLL is the DLL with Italian resources in the demo app). The last three characters in the DLL's name correspond to the hex value of the nation's locale, where "000" is the default one.

When the applications starts, it calls the GetUserDefaultLangID API function to retrieve the locale in use, then tries to create an instance of the DLL with the corresponding name. If it is possible, that DLL will be used; otherwise the default "000" DLL will be used. Using a similar method, the app can switch its resources at runtime.

The trick works because all the secondary DLLs implement then "MyApplication000" interface, therefore the main application can reference the current DLL using the same "RS" variable and still using early-binding.


