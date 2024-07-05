<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	await functions.Number().Dump("first");
	await functions.WaitForNumber().Dump("async");
	
	var cachedResults  = await Util.Cache(() => functions.WaitForNumber(), "my slow numbers");
	cachedResults.Dump("cached");
	
	
}




public static class functions
{
	public static Task<int> Number()
	{
		//await Task.Delay(1000);
		return Task.FromResult(100);
	}

	public async static Task<int> WaitForNumber()
	{
		await Task.Delay(1000);
		return 1000;
	}

}