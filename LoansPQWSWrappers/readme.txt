Compilation Info:

This project automatically gets compiled in release mode into the main c:\loanspq2\bin folder.  
However, if you make changes you want other devs to use, please build and commit the file yourself in release mode since these are just wrappers, 
there's no need for pdb files.

Note that XML Serialization Assembly is turned off to speed up compilation (Project Properties > Compile tab > Advance Compil Options >  Generate Serialization Assembly -> Off.
http://www.u2u.be/Res/Article.aspx?ART=WebServicesinSQL05 for step by step gui.


Note applicable if xml serialization assembly is turned off:

Also, please note that in release mode, the IDE will auto generate LoansPQWSWrappers.XmlSerializers.dll.  This file is suppose to help with the initial cost of making web requests, but causes stupid dictionary problems inserting duplicate keys.   
Because performance is a very unlikely problem, this dll is ignore by simply renaming it to *.junk in the PostBuild events of the project. 