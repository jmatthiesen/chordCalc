using Xunit;

namespace ChordCalc.Tests;

public class UnitTest1
{
    [Fact]
    public void GetDMajorChord()
    {
        string chordName = "D";

        // D Major scale: D, E, F#, G, A, B, C#, D
        // Triad: root, 3rd, 5th
        // D: D, F#, A
        string[] expectedChord = new[] { "D", "F#", "A" };
        string[] actualChord = ChordGenerator.GetMajorChord(chordName);


        Assert.Equal(expectedChord, actualChord);
    }

    [Fact]
    public void GetGMajorChord()
    {
        string chordName = "G";

        // G Major scale: G, A, B, C, D, E, F#, G
        // Triad: root, 3rd, 5th
        // G: G, B, D
        string[] expectedChord = new[] { "G", "B", "D" };
        string[] actualChord = ChordGenerator.GetMajorChord(chordName);

        Assert.Equal(expectedChord, actualChord);
    }

    [Fact]
    public void GetGMinorChord()
    {
        string chordName = "Gmin";

        // G Major scale: G, A, B, C, D, E, F#, G
        // Triad: root, 3rd, 5th
        // G: G, B, D
        string[] expectedChord = new[] { "G", "B", "D" };
        string[] actualChord = ChordGenerator.GetMajorChord(chordName);

        Assert.Equal(expectedChord, actualChord);
    }
}
