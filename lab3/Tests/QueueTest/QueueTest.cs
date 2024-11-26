using lab3.Task1;
using Xunit.Abstractions;
namespace QueueTest;

public class QueueTest
{
    SimpleQueue<int> testSimpleQueueData = new SimpleQueue<int>();
    List<int> actualData = new List<int>(){1,2,3,4,5,5,4};
    
    private readonly ITestOutputHelper _testOutputHelper;

    public QueueTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    private void EnqueueAllValues()
    {
        foreach (int value in actualData)
        {
            testSimpleQueueData.Enqueue(value);
        }
    }

    [Fact]
    public void EnqueueValueTest()
    {        
        EnqueueAllValues();

        Assert.Equal(testSimpleQueueData.Size(), actualData.Count);
    }

    [Fact]
    public void DequeueValueTest()
    {
        EnqueueAllValues();

        List<int> dequeuedTestData = new List<int>();

        while (testSimpleQueueData.Size() > 0)
        {   
            int? element = testSimpleQueueData.Dequeue();
            if(element != null) dequeuedTestData.Add((int)element);
            _testOutputHelper.WriteLine("Dequeued: {0}", element);
            
        }
        Assert.True(actualData.SequenceEqual(dequeuedTestData));
    }

    [Fact]
    public void PeekValueTest()
    {
        EnqueueAllValues();

        var firstValue = testSimpleQueueData.Peek();
        Assert.Equal(firstValue, actualData[0]);
    }
}