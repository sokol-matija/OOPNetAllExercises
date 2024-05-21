# Vježba 1

## Korisna online dokumentacija

- [Kako dodati formu projektu?](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/forms/how-to-add?view=netdesktop-8.0)
- [Kako pozicionirati i odrediti veličinu forme?](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/forms/how-to-position-and-resize?view=netdesktop-8.0)
- [Otvaranje jedne forme iz druge forme](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.show?view=windowsdesktop-8.0)
- [Kako promijeniti veličinu forme?](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/how-to-resize-windows-forms?view=netframeworkdesktop-4.8)
- [Promjena izgleda forme](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/changing-the-appearance-of-windows-forms?view=netframeworkdesktop-4.8)
- [Sprečavanje korisnika da odabere obrazac putem taskbara (programske trake)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.showintaskbar?view=windowsdesktop-8.0)
- [Forma koja preklapa sve ostale forme](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.topmost?view=windowsdesktop-8.0)
- [Dodavanje ili uklanjanje kontrola iz zbirke kontrola tijekom izvođenja programa](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-add-to-or-remove-from-a-collection-of-controls-at-run-time?view=netframeworkdesktop-4.8)

## Zajedničko za sve kontrole:

- **(Name)**: naziv objekta
- **Text**: tekst koji kontrola prikazuje
- **Click**: događaj kad se lijeva tipka miša pritisne i otpusti nad kontrolom
- **Size**: veličina (dimenzije) kontrole
- **ClientSize**: veličina radne površine kontrole
- **Location**: položaj kontrole unutar roditelja 
  - koordinata `(0, 0)` je gore lijevo
- **BackColor**: boja pozadine kontrole
- **Anchor**: uz koje rubove roditeljske forme se koordinate djeca-kontrola vežu
- **Dock**: "lijepi" dijete uz zadani rub roditelja
- **Controls**: kolekcija djece-kontrola unutar roditeljske forme

## Klasa Form:
- **FormBorderStyle**: definira kako izgleda i kako se ponaša okvir forme (`Sizable`/`Fixed`)
- **Show()**: metoda prikazuje formu (u nemodalnom obliku)
- **ControlBox**: kontrolira prikazuju li se kontrole za rad s prozorom
- **ShowInTaskbar**: kontrolira prikazuje li se forma u taskbaru
- **TopMost**: kontrolira prikazuje li se forma iznad drugih formi
- **WindowState**: kontrolira je li forma minimizirana/maksimizirana/normalna
- **Region**: regija koja opisuje formu (obično pravokutnik)
- **Load**: događaj nakon što je forma učitana
- **FormClosing**: događaj prije nego se forma zatvori
- Struktura **Color** ima statičku metodu `FromArgb()`
- Klasa **MessageBox** ima statičku metodu `Show()`
- Klasa **Application** ima statičku metodu `Exit()`
- Postoji klasa **Random**
- Klasa **Screen** ima statičku metodu `GetBounds()`
- Klasa **StreamWriter** ima metodu `Write()`
- Klasa **File** ima statičku metodu `Exists()`
- Klasa **StreamReader** ima metodu `ReadLine()` i svojstvo `EndOfStream`
- Klasa **GraphicsPath** omogućava dodavanje linija i krivulja
