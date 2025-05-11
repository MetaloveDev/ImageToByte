string[] files = Directory.GetFiles(@"../Images/");
for (int i = 0; i < files.Length; i++) {
    string file = files[i];
    File.WriteAllBytes(@"../Documents/" + Path.GetFileNameWithoutExtension(file) + ".txt", File.ReadAllBytes(file));
    Console.WriteLine(MathF.Ceiling(i / (float)files.Length * 100f) + "%");
}
Console.WriteLine("Done!");