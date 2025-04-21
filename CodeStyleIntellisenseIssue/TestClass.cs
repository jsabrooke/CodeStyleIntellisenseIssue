namespace CodeStyleIntellisenseIssue
{
    /// <summary>
    /// Test class.
    /// </summary>
    internal static class TestClass
    {
        /// <summary>
        /// There's an IDE0300 error shown on this method here in intellisense
        /// but it builds fine, in both VS and via command line.
        /// </summary>
        /// <returns></returns>
        public static string[] Method()
        {
            return new[] { string.Empty };
        }
    }
}
