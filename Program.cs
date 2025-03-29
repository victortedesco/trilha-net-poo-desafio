using DesafioPOO.Models;

var nokia = new Nokia("999999999", "Nokia 3310", "123456789", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

var iphone = new Iphone("888888888", "Iphone 14", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
