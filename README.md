# VB Migration Partner - Code Samples

![](images/VB_Migration_Partner_logo.jpg?raw=true)

VB Migration Partner is an innovative conversion software, by VB guru Francesco Balena, that helps you port VB6 applications to .NET. It supports virtually all VB6 features and controls, and generates .NET applications with fewer errors and in less time than any other conversion tool on the market. 

**website:** *www.vbmigration.com*

We have tested VB Migration Partner on a large number of Visual Basic 6 projects, including applications developed internally or submitted by early adopters, examples taken from books, and open source programs. 

In this page we summarize the most interesting samples we downloaded from the Internet. We have included the original URL whenever possible; however, in some cases we found these applications on our hard disks and all our attempts to locate their original URL failed. We also attempted to contact the original authors of all these samples to let them know about our initiative, but only a fraction of them answered, perhaps because most of these samples date back to year 2001 or earlier and the author’s email is no longer valid. 

Before you try the VB6 and VB.NET samples in this page, the following disclaimers are in order:
- We aren’t claiming in any way that we are the creators or that we own the copyright of any code sample listed in this page, except where noted.
- These samples are included for illustration purposes only. We don’t guarantee that the original Visual Basic 6 application works correctly under all circumstances and we aren’t endorsing it in any way. 
- We don’t guarantee that the converted VB.NET works correctly in all cases, because it might have inherited problems from the original source code.
- If you are the author of the sample and want to have your sample removed from this page, just send us an email. 
- If you happen to know the exact URL of samples for which this piece of information is missing, please let us know.

**An important note: we haven’t modified the original Visual Basic 6 source code in any way, except where noted**. In most cases our edits are limited to the addition of one or more pragmas. We have summarized all the edits in a file named MigrationNotes.txt, included in each VB.NET sample. **Likewise, we haven’t modified the VB.NET generated by VB Migration Partner in any way**.

Most VB6 samples have been instrumented with a few pragmas whose only effect is to suppress the “noise” caused by the many warnings related to code analysis, such as unused Const and Declare statements or ByRef parameters that could be bettered rendered with by-value semantics. In some cases, we included pragmas that conveniently copy data files from the VB6 folder into the VB.NET project. Such pragmas aren’t strictly necessary to have a working VB.NET application, therefore they aren’t mentioned in the list of the pragmas that are required for a correct conversion. 

## Code Samples

### Samples from “Programming Microsoft Visual Basic 6”
*by Francesco Balena – © Code Architects Srl*

![](images/programming.jpg?raw=true)

One hundred code examples and 2 megs of source code taken from Francesco Balena’s top-seller book. These samples truly stress VB6’s advanced features, including advanced graphics, object-oriented programming, database programming, forms and controls, databinding with custom data formatting, OLE drag-and-drop, basic and advanced user controls, COM components, ADO data source and data consumer classes, and Windows API methods. If an automatic conversion tool can handle these samples, it can handle anything…


### BattleShip Online
*by Adam Spicer - VB6 Source*

![](images/Battleship.jpg?raw=true)

A nice battleship game which uses Winsock control to play remotely with another player, even over internet. 

This sample shows VB Migration Partner's capabilities to easily migrate Winsock and other graphical controls. 

### EGL25
*by Harry Maugans - VB6 Source*

![](images/EGL25.jpg?raw=true)

A few people in Code Architects work with VB since its version 1.0, but we’ve rarely seen a better demonstration of Visual Basic’s graphic capabilities than this stunning application. It uses just Windows API calls – no DirectX, no OpenGL – to render, rotate, animate, etc. complex solid shapes made of thousands polygons...and does it blindly fast! What is even more unbelievable – if you aren’t familiar with VB Migration Partner, at least – is that you can convert this baby in less than 10 seconds. The resulting VB.NET code runs fine at the first attempt! 

### A Complete Web Browser
*by Juanito Dado Jr - VB6 Source*

![](images/webbrowser.jpg?raw=true)

VB Migration Partner migrates correctly even VB6 WebBrowser control.
Amoung its features we find auto-complete URL, print, HTML source window, back and forward support, progress bar and favorite window. 

This sample demonstrates how powerful is our migration engine, which converts it with no need for any pragma.

### ezDatabase
*by Daniel M. - VB6 Source*

![](images/ezdatabase.jpg?raw=true)

This sample surveys several ADODB functions, showing how VB Migration Partner deals correctly with data related applications. 

The converted .NET sample works exactly like the original VB6 application - including for some bugs in the original code - with the help of a few migration pragmas. 

### Cool Progress Bar
*by João F. S. Henriques - VB6 Source*

![](images/coolProgressBar.jpg?raw=true)

A simple sample that uses a nice progress bar filled with a gradient color transition. 

This sample shows VB Migration Partner's capabilities to easily migrate an user control which even uses the BltBit API function to render its effects. 

### LCD Clock
*by Michael Margold - VB6 Source*

![](images/lcdclock.jpg?raw=true)

A simple but intriguing application that displays a LCD clock.

VB Migration Partner converts this sample flawlessly. We have used just one pragma to polish its user interface. 

### Spell Checker
*by Shelz - VB6 Source*

![](images/spellchecker.jpg?raw=true)

An interesting tiny application that does spell checking, and does it very well. It comes with a database of over 450,000 words and uses Soundex and Levenshtein distance to find all the words that have a pronunciation “close” to a word your type. VB Migration Partner converts this program to VB.NET without having to edit the original code in any way. 

### ID Card Maker
*by Gerbert Pagtama - VB6 Source*

![](images/cardmaker.jpg?raw=true)

This application allows you to create, save, and print ID cards. You can select fonts, background, shadow color and width, and so forth. A good demo for VB Migration Partner’s graphic capabilities.

### Type-N-Sign
*by No0ne - VB6 Source*

![](images/typesign.jpg?raw=true)

A nice application that teaches you the sign language. It uses Windows API methods to create a transparent, non-rectangular form and has a few other challenges, but VB Migration Partner is quite able to handle it, after adding a couple pragmas. The converted VB.NET application works exactly like the original one, but you might want to adjust its fonts and graphical appearance after the migration.

### Stars - Virtual Night Sky
*by Jeremiah Hughes - VB6 Source*

![](images/stars.jpg?raw=true)

Enter your latitude and longiture, current date and time, and watch how the sky looks like! It comes with a large star database in text format, thus you just need to hover the mouse on a given star and learn its name, brightness, distance, etc. VB Migration Partner converts this sample flawlessly, after you’ve added a few ReleaseHDc statements to deallocate the device context that was grabbed by the hDC property. 

The only (minor) difference from the original sample is that you can’t move your perspective by pressing Shift+left arrow (or Shift+right arrow) because – quite oddly - these key combinations aren’t trapped by the .NET PictureBox control, thus the converted application uses the Alt+arrow key combination instead.  

### Barcode Generator
*by Joyprakash Saikia - VB6 Source*

![](images/barcode.jpg?raw=true)

You can generate Bar 29 and Bar 128-styled bar codes of different size, with or without a label, copy them to the clipboard and save them to a file. The converted VB.NET sample works exactly like the original VB6 application, after adding just a few pragmas. It’s a great demonstration of VB Migration Partner’s graphic capabilities. 

### Grid-Net Waves 3D
*by Srdjan Josipovic - VB6 Source*

![](images/waves.jpg?raw=true)

It’s a nice code sample that creates a 3D graph and then animates it. It doesn’t do much useful, other than providing a great example of animation techniques (as well as a great example of VB Migration Partner’s conversion abilities!). 

### A common calculator
*by Dencio - VB6 Source*

![](images/calc.jpg?raw=true)

A replica of Windows calculator, without a few advanced features. It uses control arrays, which VB Migration Partner seamlessly supports.

### MP3 Player
*by Netanel Gabbay & Moshe Pasker - VB6 Source Code*

![](images/mp3player.jpg?raw=true)

An MP3 player that uses nonrectangular forms, makes lots of calls to the Windows API, and peeks at data buried inside binary data. As if it weren’t enough, the application uses transparent Image controls to create hot spots and non-standard push buttons. This sample is a big challenge for any conversion tool.

After the migration the player works correctly is fully functional, including drag-and-drop of MP3 files from Windows Explorer. There are a few minor issues, though: the Playlist window displays spurious red pixels and the Open Dialog fails if multiple files are selected. (The latter problem is caused by a limitation of the P/Invoke portion of the .NET Framework.) Also, the nonrectangular windows display incorrectly under Microsoft Vista, but this defect is present in the original VB6 application as well.

### Photo Album
*by Salvatore Totaro - VB6 Source*

![](images/photoalbum.jpg?raw=true)

A simple photo browser and viewer, with thumbnail support and three controls that aren’t supported natively by VB.NET, namely DriveListBox, DirListBox, and FileListBox.

The VB6 code migrates correctly without the need for any pragmas. The VB.NET code works as intended, except that the current image in thumbnail view isn’t displayed correctly. The reason: the VB6 program uses an Image control with red border and transparent background to display a frame around the selected image. The .NET Framework doesn’t support Image controls with transparent background; VB Migration Partner does support such controls, but only if they have no border.

### Archive Explorer
*by Marco v/d Berg - VB6 Source*

![](images/archiveExpl.jpg?raw=true)

A browser for ZIP files that can peek at compressed files and extract them to a folder. It demonstrates that VB Migration Partner correctly converts complex Declare statement (e.g. SHBrowseForFolder) and that nontrivial Structures are correctly read from and written to disk. The sample consists of 4000+ lines of code, subdivided in 5 modules and 11 classes, yet it takes only one migration pragma to convert and run correctly as a VB.NET application.

### School
*by Philip V. Naparan - VB6 Source*

![](images/school.jpg?raw=true)

An MDI application to manage students, classes, and so forth. With its 30 forms and 3 modules, this program is more akin to a “real-world” business applications than most other samples in this page. (We would like to offer more examples like this, but few business applications are available as open source.)

We had to add just two pragmas to have it compile and execute correctly under VB.NET. All the features of the original application are converted correctly except print reports. (VB Migration Partner doesn’t support the DataReport designer.)

### Expression Evaluator
*by Konstantin Tretyakov - VB6 Source*

![](images/Eval.jpg?raw=true)

A class that evaluates an expression stored in a string. VB.NET still lacks of a similar function, so it can be useful to .NET Framework developers too.

### Caro
*by <unknown author> - VB6 Source Code *

![](images/caro.jpg?raw=true)

A board game similar to Go. It demonstrates that VB Migration Partner converts graphic primitives, handles arrays with nonzero lower bounds, Variant variables, and late binding.

### Pacman
*by Pookie - VB6 Source*

![](images/pacman.jpg?raw=true)

A nearly perfect replica of the classic arcade game. The VB6 code uses quite a few advanced features, such as playing WAV files, displaying complex graphics, and animating multiple sprites using the BltBit API function. Only a conversion tool that relies on a support library can convert such an application.

For the VB.NET project to run correctly we had to add one ArrayBounds pragma and some InsertStatement pragmas. The only relevant defect in the VB.NET code is an excessive amount of flickering, an issue that could be easily fixed by means of double buffering. (Such flickering is especially noticeable under Microsoft Vista with Aero theme.) Except for this detail, the VB.NET version of the game is fully playable.

### Classic VB
*by <unknown author> - VB6 Source Code*

![](images/classicvb.jpg?raw=true)

A nontrivial Notepad-like MDI Application, which leverages a vast assortment of features.

A couple of pragmas have been inserted in the original VB6 code to ensure that the splash screen be displayed correctly and to ensure that the MDI child window to appear in normal (nonmaximized) state.

### Tetris
*by Enrico Melani - VB6 Source*

![](images/tetris.jpg?raw=true)

The title speaks for itself. This one-form sample uses arrays of Image controls to create different shapes and calls Windows API to play sounds. All it needs to convert to VB.NET is an ArrayBounds pragma.

### SQL Server Documenter
*by RaiVeN - VB6 Source*

![](images/sqlsrv.jpg?raw=true)

A handy utility that uses the SQLDMO type library to find all the SQL Servers on the network, explore their tables and indexes, export the result to Microsoft Excel, etc. The VB.NET version compiles and runs correctly at the first attempt, without the need of any pragma.

### 3Ddefline
*by Duccio/Duke - VB6 Source*

![](images/3defline.jpg?raw=true)

An intriguing program to display math functions in 3D. In addition to stressing VB6 graphic capabilities, this sample shows how to use the ScriptControl to evaluate a math expression entered by the user. Despite all these challenges, the source code compiled to VB.NET and run correctly, simply adding few pragmas.

### BC-52
*by D. Rijmenants - VB6 Source*

![](images/bc-52.jpg?raw=true)

A truly astonishingly simulation of a ciphering machine. BC-52’s source code is commented more than adequately, yet you need to be a ciphering guru to understand what each statement does. As if ciphering wasn’t a complex topic enough in itself, this code relies on many advanced VB6 programming techniques, such as transparent Image controls used to detect mouse activity and simulate “pushable” keys. We can’t think of how we could have translated it to VB.NET without an automatic conversion tool like VB Migration Partner.

The VB6 code migrates without any problem and the VB.NET application behaves almost exactly like the original one. There are a few minor issues, though complex graphical output is slightly different from the original version, and a few options don’t work correctly. In spite of these shortcomings, we included BC-52 in this page because we consider the ability to migrate such a complex application as a big success of our tool. 

### CD Archive
*by Elan Hasson - VB6 Source*

![](images/cdarchive.jpg?raw=true)

A simple utility that allows you to scan a CD and archive its contents on an MDB database for subsequent searches. We added one ArrayBounds pragma to handle an array with nonzero lower index and two UseSystemString pragmas to pass a structure to the FindFirstFile/FindNextFile Windows API methods.

### Code Library
*by Philip V. Naparan - VB6 Source*

![](images/codelibrary.jpg?raw=true)

A code librarian that allows you to store fragments written in any programming language. It even comes with a small database of useful VB6, VB.NET, ASP.NET and Java snippets. VB Migration Partner converts its 10 forms and 1 module (1200 total lines of code) in a blink. What’s more important, the VB.NET code compiles and executes correctly adding few pragmas.

### Master Mind
*by Alberto Vettolani - VB6 Source*

![](images/mastermind.jpg?raw=true)

A simple MasterMind game, where you have to guess the hidden color combination chosen by the computer. Messages are in Italian, but it shouldn’t be a serious obstacle. A black dot in the result pane means that you guessed a color in the right position, whereas a white dot means that the color is in the solution but in a different position. It’s a lot of code (over 4000 lines), but we needed just two pragmas to have it run correctly under VB.NET.

### Mouse Recorder
*by CodeXP - VB6 Source*

![](images/mouserecorder.jpg?raw=true)

A small but quite useful utility that records your mouse clicks and movements, saves them to file, and replays them so that you can automate many repetitive tasks. This sample counts fewer than 1000 lines, yet it uses many Windows API calls. VB Migration Partner converts it to VB.NET without the need of pragmas.

### Phone Book
*by Arbie Sarkissian - VB6 Source*

![](images/phonebook.jpg?raw=true)

Another program to store names, addresses, and phone numbers. In spite of its simplicity, this sample is a serious challenge for an automatic conversion tool. It uses the Shell_NotifyIcon Windows API method to display an icon in the tray area and shows a popup menu when the icon is clicked; it displays a print preview dialog that relies on graphic methods and custom ScaleMode settings. After we added seven pragmas to solve all these issues, the VB.NET code run flawlessly.

### Ald WinInvaders
*by Aldo Prinzi - VB6 Source*

![](images/aldinvaders.jpg?raw=true)

The VB version of a classic arcade. It is implemented with arrays of Image controls and other graphical tricks. VB Migration Partner converts it nicely to VB.NET, even if there is a bit too much flickering. If our tool can handle this game, just imagine of what it can do with your business applications (which aren’t supposed to flicker at all)