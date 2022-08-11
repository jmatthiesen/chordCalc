// TODO: Ask for the key
// TODO: Ask for Major or Minor key
// TODO: Ask for chord
// TODO: Output the chord

using ChordCalc.Backend;

Console.WriteLine("Chord name?");

var chordName = Console.ReadLine();
var chordNotes = ChordGenerator.GetMajorChord(chordName);
Console.WriteLine(String.Join(", ", chordNotes));

Console.ReadKey();