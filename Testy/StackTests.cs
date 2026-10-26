using NUnit.Framework;
using System.Collections.Generic;

namespace Testy
{
    [TestFixture]
    public class StackTests
    {
        // Testy dla metody Push w klasie Stack
        [Test]
        public void Push_NullObject_ThrowsArgumentNullException()
        {
            var stack = new Stack<object>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidObject_IncreasesCount()
        {
            var stack = new Stack<string>();
            stack.Push("Ala ma kota");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        // Testy dla metody Pop w klasie Stack
        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_NonEmptyStack_DecreasesCount()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_NonEmptyStack_ReturnsLastPushedObject()
        {
            var stack = new Stack<string>();
            stack.Push("Ala ma kota");
            stack.Push("Kot ma Ale");
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("Kot ma Ale"));
        }

        // Testy dla metody Peek w klasie Stack
        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_NonEmptyStack_ReturnsLastPushedObject()
        {
            var stack = new Stack<string>();
            stack.Push("Ala ma kota");
            stack.Push("Kot ma Ale");
            var result = stack.Peek();
            Assert.That(result, Is.EqualTo("Kot ma Ale"));
        }
    }
}
