using System;

namespace ChordCalc.Backend
{
    // Notes:
    // Key: A:
    // Major intervalic formula: WWHWWWH
    // Minor intervalic formula: WHWWHWW
    // 
    // A, B, C#, D, E, F#, G#, A
    // 1, 2, 3, 4, 5, 6, 7, octave'

    public class ChordGenerator
    {
        // TODO: Support flats
        static string[] notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

        public static string[] GetMajorChord(string? chordName)
        {
            // TODO: Chord parsing needs to understand not just simple note names, but things like Dmaj7, Dsus2, etc.

            // Calculate scale
            int root = Array.IndexOf(notes, chordName); // Root note
            if (root == -1)
            {
                throw new Exception("Unexpected chord name");
            }

            // Hardcoded major scale for now
            int scaleNote2 = GetNote(root + 2); // W
            int scaleNote3 = GetNote(scaleNote2 + 2); // W
            int scaleNote4 = GetNote(scaleNote3 + 1); // H
            int scaleNote5 = GetNote(scaleNote4 + 2); // W
            int scaleNote6 = GetNote(scaleNote5 + 2); // W
            int scaleNote7 = GetNote(scaleNote6 + 2); // W
            int scaleNote8 = GetNote(scaleNote7 + 1); // H

            string[] scale =
            {
                notes[root],
                notes[scaleNote2],
                notes[scaleNote3],
                notes[scaleNote4],
                notes[scaleNote5],
                notes[scaleNote6],
                notes[scaleNote7],
                notes[scaleNote8]
            };

            // Take root, 3rd, and 5th intervals

            return new string[] { scale[0], scale[2], scale[4] };
        }

        private static int GetNote(int note)
        {
            if (note > notes.Length - 1)
            {
                note -= notes.Length;
            }

            return note;
        }
    }
}