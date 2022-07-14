using System;
using System.Linq;
using System.Runtime.InteropServices;
using UglifierLib;
using Xunit;

namespace Uglifier.Tests
{
    public class IndentationUglificationModuleTests
    {
        private readonly UglificationModule _sut;
        public IndentationUglificationModuleTests()
        {
            _sut = new IndentationUglificationModule();
        }
        
        [Fact]
        public void NoIndentation_RemovesAllIndentation()
        {
            // Arrange
            string code = CodeConstants.Example1;

            // Act
            code = _sut.Uglify(code, IndentationUglificationMode.NoIndentation);

            // Assert
            string line2 = code.Split('\n')[1];
            Assert.NotEqual(' ', code[0]);
            Assert.NotEqual(' ', code[1]);
            
            Assert.NotEqual(' ', line2[0]);
            Assert.NotEqual(' ', line2[1]);
        }
        [Fact]
        public void LineSpaceIndentation_HasAnAmountOfSpacesEqualToTheLineNumber()
        {
            // Arrange
            string code = CodeConstants.Example1;

            // Act
            code = _sut.Uglify(code, IndentationUglificationMode.LineNumberAmountOfSpace);

            // Assert
            string line1 = code.Split('\n')[0];
            string line2 = code.Split('\n')[1];
            string line6 = code.Split('\n')[5];
            Assert.Equal(' ', line1[0]);
            Assert.NotEqual(' ', line1[1]);
            
            Assert.Equal(' ', line2[0]);
            Assert.Equal(' ', line2[1]);
            Assert.NotEqual(' ', line2[2]);
            
            Assert.Equal(' ', line6[0]);
            Assert.Equal(' ', line6[1]);
            Assert.Equal(' ', line6[2]);
            Assert.Equal(' ', line6[3]);
            Assert.Equal(' ', line6[4]);
            Assert.Equal(' ', line6[5]);
            Assert.NotEqual(' ', line6[6]);
        }
        [Fact]
        public void LineSpaceIndentationInvert_IsTheInvertOfLineSpaceIndentation()
        {
            // Arrange
            string code = CodeConstants.Example1;

            // Act
            code = _sut.Uglify(code, IndentationUglificationMode.LineNumberAmountOfSpaceInverted);

            // Assert
            string[] lines = code.Split('\n');
            string line1 = lines[0];
            string line6 = lines[5];
            for (int i = 0; i < lines.Length - 1; i++)
            {
                Assert.Equal(' ', line1[i]);
            }

            Assert.NotEqual(' ', line1[lines.Length + 1]);
            
            for (int i = 0; i < lines.Length - 6; i++)
            {
                Assert.Equal(' ', line6[i]);
            }

            Assert.NotEqual(' ', line6[lines.Length - 6 + 1]);
            
            Assert.NotEqual(' ', lines.Last()[0]);
        }
        [Fact]
        public void RandomIndentation_IsDifferentEverytime()
        {
            // Arrange
            string code1 = CodeConstants.Example1;
            string code2 = CodeConstants.Example1;

            // Act
            code1 = _sut.Uglify(code1, IndentationUglificationMode.RandomIndentation);
            code2 = _sut.Uglify(code2, IndentationUglificationMode.RandomIndentation);

            // Assert
            Assert.NotEqual(code1, code2);
        }
    }
    public class CodeConstants
    {
        public const string Example1 = "    public class ExampleCode\r\n    {\r\n        private void Example()\r\n        {\r\n            int id = 1;\r\n            string firstName = \"nicolai\";\r\n            string lastName = \"heuck\";\r\n            string address = \"sønderborg\";\r\n            int postalCode = 6400;\r\n\r\n            if (id < 2)\r\n            {\r\n                Console.WriteLine(\"a\");\r\n            }\r\n            else if (id == 69)\r\n            {\r\n                Console.WriteLine(\"nice\");\r\n\r\n                if (firstName == \"nicolai\")\r\n                {\r\n                    Console.WriteLine(\"googlelai\");\r\n                }\r\n                else\r\n                {\r\n                    switch (firstName)\r\n                    {\r\n                        case \"casper\":\r\n                            Console.WriteLine(\"mr vw\");\r\n                            break;\r\n                        case \"tobias\":\r\n                            Console.WriteLine(\"snackr\");\r\n                            break;\r\n                        default:\r\n                            Console.WriteLine(\"human\");\r\n                            break;\r\n                    }\r\n                }\r\n            }\r\n            else\r\n            {\r\n                Console.WriteLine(\"b\");\r\n            }\r\n\r\n            Console.WriteLine($\"{id} {firstName} {lastName} {address} {postalCode}\");\r\n        }\r\n        public class Person\r\n        {\r\n            public int Id { get; set; }\r\n            public string FirstName { get; set; }\r\n            public string LastName { get; set; }\r\n            public string Address { get; set; }\r\n            public int PostalCode { get; set; }\r\n        }\r\n    }";
    }
}