@echo off
color a
for %%a in (*.RCO) DO CXMLDecompiler.exe ReactNative.Components.CommonAssets\ReactNative.Components.CommonAssets.xml -c 
DEL Output\ReactNative.Components.CommonAssets.rco
move -c Output
rename Output\-c ReactNative.Components.CommonAssets.rco
%%a output
