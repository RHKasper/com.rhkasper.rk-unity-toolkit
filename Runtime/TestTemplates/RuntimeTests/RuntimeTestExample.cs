using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace RKUnityToolkit.TestTemplates.RuntimeTests
{
    public class RuntimeTestExample : MonoBehaviour
    {
	    [SetUp]
	    public void SetUpTestEnvironment()
	    {
		    
	    }

	    [UnityTest]
	    public IEnumerator ExampleTest()
	    {
		    float startTime = Time.time;
		    yield return null;
		    Assert.AreNotEqual(startTime, Time.time);
	    }
    }
}
