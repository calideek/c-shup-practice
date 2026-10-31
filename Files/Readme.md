# Sharraxaadda Hababka Maareynta Faylasha (File Handling Functions) ee assignment8

Mashruucan wuxuu muujinayaa hababka kala duwan ee loo maareeyo faylasha (File Handling) gudaha C# Windows Forms, iyadoo la isticmaalayo maktabadda `System.IO`. Hoos waxaad ku arki doontaa dhammaan shaqooyinka (functions) faylasha ee koodka ku dhex jira iyo waxa ay qabtaan.

---

## 1. Qorista Faylka (Writing to a File)

### `File.CreateText(string path)`
* **Shaqadeeda:** Waxay abuurtaa fayl cusub oo qoraal ah (text file). Haddii faylku horay u jiray, wuu tirtirmaa waxaana lagu beddelaa mid cusub.
* **Koodka ku jira:** `button1_Click`
* **Habka loo isticmaalay:** Waxay soo celisaa shey (object) u gaar ah `StreamWriter` si loogu qoro xog.

### `StreamWriter.WriteLine(string value)`
* **Shaqadeeda:** Waxay xogta (qoraalka) ku qortaa faylka dhexdiisa, iyadoo dhamaadka qoraalk kasta ku dareysa saf cusub (new line).
* **Koodka ku jira:** `button1_Click`

---

## 2. Akhrinta Faylka (Reading from a File)

### `File.OpenText(string path)`
* **Shaqadeeda:** Waxay furtaa fayl qoraal ah oo horay u jiray si loo akhriyo.
* **Koodka ku jira:** `button4_Click` iyo `button2_Click`
* **Habka loo isticmaalay:** Waxay soo celisaa shey u gaar ah `StreamReader`.

### `StreamReader.ReadLine()`
* **Shaqadeeda:** Waxay faylka ka akhrisaa hal saf (line) markasta. Haddii faylku dhamaado, waxay soo celisaa `null`.
* **Koodka ku jira:** `button4_Click`

### `StreamReader.EndOfStream`
* **Shaqadeeda:** Waa hanti (property) sheegta haddii la gaaray dhamaadka faylka (`true`) iyo haddii kale (`false`). Waxaa loo isticmaalaa in lagu wado loop-ka inta faylka wax ku jiran.
* **Koodka ku jira:** `button4_Click`

### `File.ReadAllLines(string path)`
* **Shaqadeeda:** Waxay mar qura wada akhrisaa dhammaan safafaadka faylka, waxayna u beddeshaa habayn qoraal ah (string array `string[]`). Faylka si otomaatig ah ayay u furtaa una xirtaa.
* **Koodka ku jira:** `button5_Click`

### `File.ReadAllBytes(string path)`
* **Shaqadeeda:** Waxay u akhrisaa faylka sidii xog binary ah (bytes) waxayna soo celisaa array ah (`byte[]`). Tani waxay faa'iido leedahay marka la akhrinayo faylasha aan qoraalka ahayn (sida sawirada ama audio).
* **Koodka ku jira:** `button6_Click`

### `StreamReader.ReadBlock(char[] buffer, int index, int count)`
* **Shaqadeeda:** Waxay faylka ka akhrisaa xaddi xaddidan oo xarfo ah (characters) iyadoo ku kaydisa meel ku meel gaar ah (buffer). Koodkaaga wuxuu akhriyaa ugu badnaan 20 xarfo.
* **Koodka ku jira:** `button7_Click`

---

## 3. Tirtirista iyo Cusboonaysiinta (Deleting and Updating)

### `File.Exists(string path)`
* **Shaqadeeda:** Waxay hubisaa in faylka la raadinayo uu ku yaalo dhabada (path) la siiyay iyo in kale. Waxay soo celisaa `true` ama `false`.
* **Koodka ku jira:** `button5_Click` iyo `button2_Click`

### `File.Delete(string path)`
* **Shaqadeeda:** Waxay si joogto ah u tirtirtaa faylka la cayimay.
* **Koodka ku jira:** `button2_Click`

### `File.WriteAllLines(string path, string[] contents)`
* **Shaqadeeda:** Waxay abuurtaa fayl cusub (ama waxay dowlisaa kii horay u jiray) iyadoo mar qura ku qoreysa array-ga qoraalka ah ee loo dhiibay. Koodkaaga waxaa loo isticmaalay in dib loogu qoro faylka marka shay laga tirtiro `listBox1`.
* **Koodka ku jira:** `button3_Click`

---

## 4. Xirista Faylka (Closing Resources)

### `StreamWriter.Close()` / `StreamReader.Close()`
* **Shaqadeeda:** Waxay xirtaa faylka furnaa si nidaamka qof kale ama shaqo kale u isticmaali karo, sidoo kale waxay xaqiijisaa in xogtii la qorayay ay si sax ah ugu badbaaddo disk-iga.
  
### `using` Statement
* **Shaqadeeda:** Waxay si otomaatig ah u xirtaa faylka (iyadoo wadata `Dispose()`) marka uu dhameysto shaqada gudaha ku jirta, xitaa haddii uu cilad (error) dhaco.
* **Koodka ku jira:** `button7_Click`
