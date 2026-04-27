# NotesApp - Jegyzetkezelő Alkalmazás

## 1. Bevezetés
Az alkalmazás célja egy felhasználóbarát, kategória-alapú jegyzetkezelő rendszer létrehozása, amely lehetővé teszi a felhasználók számára a hatékony adatrendezést és nyomon követést. A program különböző típusú jegyzetek (szöveges, feladat, emlékeztető) létrehozására, szerkesztésére és tárolására szolgál.

## 2. Funkcionális Működés
* **Bejelentkezés:** A program indításakor hitelesítés szükséges. A felhasználók a regisztrált nevükkel léphetnek be, amely biztosítja az adatok elkülönítését.
* **Jegyzet típusok:**
    * **BigTextNote:** Hosszabb, formázott szöveges jegyzetek.
    * **TaskNote:** Feladatok nyilvántartása elvégezve/nem elvégezve állapottal.
    * **ReminderNote:** Határidőhöz kötött emlékeztetők.
* **Adatkezelés:** A program a felhasználók által megadott adatokat szöveges fájlokban tárolja elválasztó karakterek használatával (*data.txt, users.txt*). A beolvasáskor polimorfizmust alkalmazva a program automatikusan felismeri az adatokat és a megfelelő osztályból példányosítja azokat.
* **Felhasználói felület:** Az alkalmazás modern, egységes megjelenésű ablakokat használ. A "Remember Me" funkció segítségével az utoljára bejelentkezett felhasználó neve egy külön fájlban (remembered.txt) tárolódik a kényelem érdekében.

## 3. Technikai Megvalósítás
* **Objektumorientáltság:** A rendszer egy absztrakt `Note` ősosztályt használ, amelyből a konkrét jegyzettípusok leszármazott osztályokként deklarálhatóak, ezt egy grafikus felületen keresztül végezhetjük.
* **Öröklődés:** Az alkalmazás ablakai egy közös `BaseForm` osztályból örökölnek, amely tartalmazza a közös vizuális beállításokat és a `protected` láthatóságú üzenetkezelési metódusokat.
* **Eseménykezelés:** A program a `FormClosing` eseményeket használja a szabályozott kilépéshez, lehetővé téve a mentés nélküli bezárás megakadályozását és a kijelentkezési folyamat kezelését.
* **Adatok átadása:** Az űrlapok közötti kommunikáció konstruktorokon és publikus tulajdonságokon keresztül történik.

## 4. Használati Útmutató
* Indítsa el az alkalmazást.
* A regisztrációs felületen adjon meg egy **nevet**, egy minimum 3 karakteres **felhasználónevet** és egy minimum 5 karakteres **jelszót**.
* Regisztráljon egy új **felhasználót**.
* Jelentkezzen be a **felhasználónevével** és **jelszavával**.
* **Új jegyzet** létrehozásához használja a **`New` > `Note`** gombot a menüsor `File` oszlopából, válassza ki a kívánt típust, majd a mentés gombbal eltárolhatja.
* Jelölje ki a kívánt jegyzetet a listából, ekkor egy kis dobozban alul megjelenik a jegyzet típusa és előnézete.
* A jegyzet tartalmának szerkesztéshez használja az **`Open Note`** gombot a menüsor `File` oszlopában
* A jegyzet átnevezéséhez vagy törléséhez használja a **`Rename`** vagy **`Delete`** gombot a menüsor `File` oszlopában
* Amennyiben szerkesztés közben mentés nélkül kívánja bezárni az ablakot a program rákérdez, hogy kívánja-e menteni vagy bezárja mentés nélkül.
* Amennyiben szerkesztés után nem frissülnek az adatok azonnal, a menüsorban található **`Refresh`** gombbal frissíteni tudjuk az adathalmazt.
* Kijelentkezéshez használja a menüsorban található **`Logout`** gombot, ekkor be tud jelentkezni egy másik felhasználóval az alkalmazás újraindítása nélkül.
Amennyiben be szeretné zárni az alkalmazást úgy, hogy be van jelentkezve a program megkérdezi, hogy csak kijelentkezni szeretnénk vagy végleg bezárni a programot.
