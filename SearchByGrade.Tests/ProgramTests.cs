using System;
using Xunit;

namespace SearchByGrade.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void SearchStudentsWorksWhenNoMatch()
        {
            Student[] students = { new Student("Ioana", 9.5), new Student("Gabi", 9), new Student("Maria", 9) };
            double markToFind = 8;
            Assert.Equal(-1, Program.SearchStudent(students, markToFind));
        }

        [Fact]
        public void SearchStudentsWorksWhenOneMatch()
        {
            Student[] students = { new Student("Ioana", 9.5), new Student("Gabi", 8), new Student("Maria", 9) };
            double markToFind = 8;
            Assert.Equal(1, Program.SearchStudent(students, markToFind));
        }

        [Fact]
        public void SearchStudentsWorksWhenMultipleMatch()
        {
            Student[] students = { new Student("Ioana", 9.5), new Student("Gabi", 8), new Student("Maria", 8) };
            double markToFind = 8;
            Assert.Equal(1, Program.SearchStudent(students, markToFind));
        }
    }
}
