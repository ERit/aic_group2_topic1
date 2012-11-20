Hallo allerseits!

Hab mal einen Versuch des Neu-Anfanges gestartet und den Teil mit der Sentiment-Analyse als WCF-Service implementiert. Eine gute Anleitung für WCF 
in 6 Schritten ist unter: http://msdn.microsoft.com/en-us/library/ms734712.aspx zu finden. 

Ich hab das Beispiel mal durchprobiert und dann in der gleichen Art und Weise mal unser StatisticService implementiert.

Neue Services (+Interfaces) gehören des Projekt: Sentiment Lib

Ausführen:
1. Host starten als Administrator (ich starte da direkt die SentimentHost\bin\Debug\SentimentHost.exe, denke mal das geht noch einfacher, habs aber nix gefunden)
(2. Im Client Rechtsklick auf die StatisticServiceReference - "Update Service Reference")
3. SentimentClient Run

-> bissl warten, dann sollte sich in den 2 Consolen Fenster was tun


anm.1: nicht schrecken wegen den 15mb -> das ist die tweetsharp api - wird verwendet für die Twittersuche.
anm.2: ich denke wir brauchen für teil1 noch keine "webapplikation" an sich, also keine website mit login undso, das ist erst Stage 2.4 - console müsste reichen, was meint ihr?
anm.3: bei Fragen/Anregungen/ oder wenn ihr meint dass das anders gehört - Skype oder Mail :)

lg Manu
