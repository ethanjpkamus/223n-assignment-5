#Author: Ethan Kamus
#email: ethanjpkamus@csu.fullerton.edu

rm *.dll
rm *.exe

echo View the list of source files
ls -l

echo "Compile appletreeuserinterface.cs:"
mcs -target:library -r:System.Drawing.dll -r:System.Windows.Forms.dll -out:appletreeuserinterface.dll appletreeuserinterface.cs

echo "Compile and link appletreeusermain.cs:"
mcs -r:System -r:System.Windows.Forms -r:appletreeuserinterface.dll -out:appletree.exe appletreeusermain.cs

echo "Run the program Apple Tree Program"
./appletree.exe

echo "The bash script has terminated."
