@echo off
color a
for %%a in (*.RCO) DO CXMLDecompiler.exe Sce.Vsh.ShellUI.TopMenu\Sce.Vsh.ShellUI.TopMenu.xml -c 
DEL Output\Sce.Vsh.ShellUI.TopMenu.rco
move -c Output
rename Output\-c Sce.Vsh.ShellUI.TopMenu.rco
%%a output
