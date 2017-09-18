#!/bin/txt
#
# Program Name:: Type-N-Sign
# Version 0.2
#
# By:: No()ne
# Email:: data_tune@hotmail.com
#

Type-n-sign is a program I put together in order to help raise awareness of ASL (American Sign Language) as a second language. This Program and Source (When Completed) are written for a special lady, Who's Father is the founder of "Georgia School for the Deaf". This Code is Licensed under GNU. (Please read what's to be added.)

This is a BETA version 0.2.  I've uploaded the latest copy.

It sports a virtual point and click keyboard. By ether hitting a key or typing directly into the console, Type-n-sign will then show the appropriate hand sign. Has play back, continuous play, and Speed control features. Even supports the ability to switch out hand modules (Have a Web or Digital Cam? Customize/personalize Type-N-sign to your needs...) Current module was created using poser.

[I take no responsibility for friends helping friends cheat on spelling test using this knowledge....]


=================
Technical Notes::
=================

Type-n-sign uses a transparent form based on the background picture (Pure API). The latest version still suports the transparent form, but loads its' data from a file (Loads in under a second now) and if the data file isn't found it will create another one. Since it's a transparent form, I relied on Popup menus and a graphical interface based on the picture itself.  Reads and writes to ini file as needed. (Checks to see if program is running for the first time, if so, sets a default file and brings up Options window.)

To Be Added::
Working on adding a Calculator (Which supports full numbering system). Also an encyclopedia is in the works.

This Version is only being distributed at the Planet for BETA/Debuging testing. If you find any bugs, think of anything that needs to be added, please let me know.


====================
Adding new Modules::
====================

a) Create the directory where pictures/modules will be stored.
b) Create pictures a.jpg ... z.jpg and save in new directory.
c) Open notepad type in what ever you want, then save this file as Hands.mod in the new directory as well.
d) Now under options (In Typ-n-sign) select your new folder... Wala, have fun.

If pictures don't show, check your path (Defaults to \sign\hands.mod)

