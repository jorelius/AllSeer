// See https://aka.ms/new-console-template for more information
using AllSeer.Cli.Usecases;
using PowerArgs;

await new CreateNewProfile().Execute();

Controller? parsed = null;
try
{
	Console.WriteLine();
	Args.InvokeAction<Controller>(args);
}
catch (ArgException ex)
{
	Console.WriteLine(ex.Message);
	Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<Controller>());
}

// exit if help is requested
if (parsed == null || parsed.Help)
{
	return;
}