using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    /// Scenario: Add items with different priorities and dequeue in correct order
    // Expected Result: Dequeue returns items from highest to lowest priority
    // Defect(s) Found: If Dequeue does not return highest priority first
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("Medium Priority", 5);
        priorityQueue.Enqueue("High Priority", 10);

        Assert.AreEqual("High Priority", priorityQueue.Dequeue());
        Assert.AreEqual("Medium Priority", priorityQueue.Dequeue());
        Assert.AreEqual("Low Priority", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with same priority and test FIFO behavior
    // Expected Result: Dequeue returns items with same priority in order they were added
    // Defect(s) Found: If Dequeue picks the last of same-priority items instead of first
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: Dequeue throws an InvalidOperationException
    // Defect(s) Found: If Dequeue does not throw an exception when queue is empty
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        priorityQueue.Enqueue("Only Item", 1);
        Assert.AreEqual("Only Item", priorityQueue.Dequeue());
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with mixed priorities
    // Expected Result: Always returns the highest priority item first, ties broken FIFO
    // Defect(s) Found: If queue order is not maintained correctly
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);
        priorityQueue.Enqueue("Another Medium", 5);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Another Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

}