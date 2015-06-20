typedef int ( *ANSWERCB )( int );

static ANSWERCB cb;

extern "C" {
  float FooPluginFunction();

  void FooCallbackFunction(ANSWERCB fp);
}

float FooPluginFunction()
{
	return 1.0;
}

void FooCallbackFunction(ANSWERCB fp)
{
	cb = fp;

	if (cb)
	{
		cb(50);
	}
}