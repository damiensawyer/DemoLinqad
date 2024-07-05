<Query Kind="Program">
  <Reference Relative="..\MyLib\bin\Debug\net8.0\MyLib.dll">C:\temp\code\MyApp\MyLib\bin\Debug\net8.0\MyLib.dll</Reference>
  <Namespace>MyLib</Namespace>
  <IncludeWinSDK>true</IncludeWinSDK>
</Query>

void Main()
{
	Functions.Add(10,20).Dump();
}


