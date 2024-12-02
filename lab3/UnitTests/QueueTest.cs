using lab3.Src;
using Xunit.Abstractions;
namespace QueueTest;

public class QueueTest
{
    List<int> actualData = new List<int>(){1,2,3,4,5,5,4};
    
    private void EnqueueAllValues(IQueue<int> testQueueImplementation)
    {
        foreach (int value in actualData)
        {
            testQueueImplementation.Enqueue(value);
        }
    }

    public static IEnumerable<object[]> QueueImplementationsForTest()
    {
        yield return new object[]{new SimpleQueue<int>()};
        yield return new object[]{new LinkedListQueue<int>()};
        yield return new object[]{new CircularQueue<int>(10)};
    }

    [Theory]
    [MemberData(nameof(QueueImplementationsForTest))]
    public void EnqueueValueTest(IQueue<int> testQueueImplementation)
    {        
        EnqueueAllValues(testQueueImplementation);

        Assert.Equal(testQueueImplementation.Size(), actualData.Count);
    }

    [Theory]
    [MemberData(nameof(QueueImplementationsForTest))]
    public void DequeueValueTest(IQueue<int> testQueueImplementation)
    {
        EnqueueAllValues(testQueueImplementation);

        List<int> dequeuedTestData = new List<int>();

        while (testQueueImplementation.Size() > 0)
        {   
            int? element = testQueueImplementation.Dequeue();
            if(element != null) dequeuedTestData.Add((int)element);
            
        }
        Assert.True(actualData.SequenceEqual(dequeuedTestData));
    }

    [Theory]
    [MemberData(nameof(QueueImplementationsForTest))]
    public void PeekValueTest(IQueue<int> testQueueImplementation)
    {
        EnqueueAllValues(testQueueImplementation);

        var firstValue = testQueueImplementation.Peek();
        Assert.Equal(firstValue, actualData[0]);
    }
}