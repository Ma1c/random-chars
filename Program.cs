while (true) {
	Random rand = new Random();
	string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
	char randomChar = allowedChars[rand.Next(0, allowedChars.Length)];
	Console.Clear();
	Console.Write(randomChar);
	Console.Write(randomChar);
	Console.Write(randomChar);
}