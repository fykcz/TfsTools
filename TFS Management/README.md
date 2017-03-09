# Vývoj s TFS
## Unce upon a time
V některém předchozím působišti jsme přivohnuli TFS k obrazu našemu. Bylo to násilné, hrubé ... a fungovalo to těžkopádně. Napsali jsme si návod, jak s tím pracovat. Nebylo to vždycky úspěšné. Ale abych na tu dobu nezapomněl, tak jsem si ty pravidla tady nechal.

## Základní společná pravidla by JM
* V TFS ([Overview](http://XXX/_dashboards#activeDashboardId=1c8463d2-db9b-4315-8f08-e2e7c78a97d2))
jsou všechny údaje přestrukturovány tak, aby bylo na první pohled jasné, na čem se má prioritně pracovat ve stávající verzi.
* Stávající verze je vždy uvedena pod odstavcem [current](http://XXX/_backlogs/Iteration/4.5/4.5.2016-04%20(nezn%C3%A1m%C3%A9))
A měla by tam být vždy jen jedna. Na toto se můžete dívat i z VS přes volby v Team Explorer (kdyby někdo nevěděl).
* Úkoly uvedené pod tímto odkazem jsou jediné úkoly, které lze commitovat zpět do verze. 
* Pokud nemáte pod tímto nic uvedeno , případně všechno hotovo, můžete, přímo musíte, pracovat na dalších úkolech, tak jak jsou přiděleny podle priorit.
Tyto úkoly ovšem nesmíte commitovat zpátky do TFS, ale pokud je máte hotové a nechcete riskovat jejich lokální ztrátu uložíte je do „šuplíku“ (SHELVE) a pracujete na dalších úkolech.
* Pokud v dalších buildech dojde na tento, u vás již hotový, task, vezmete ho ze „šuplíku“ zpět, mělo by to nahlásit, že třeba původní kód změnil někdo jiný a vyzvat k revizi a provedete commit.
Toto je zavedeno z důvodu, aby bylo možné rychleji vydávat jednotlivé verze aplikace k uživatelům.
* Zásobník práce je vždy v každé verzi pod záložkou končící „.X“ nebo může být nadefinována i další verze buildu, ale vždy je jedna platná („commitovací“) a ostatní jsou „šuplíkové“!
* Zároveň byly ještě jednou upraveny obrazovky pro zadávání záznamů. Sloupec metasystém by přejmenován na alter ID a pořád v něm je jednoznačné číslo alteru (alterů), které souvisí s daným záznamem.
Sloupec build byl přejmenován na metasystém ID a bude v něm vyplněno příslušné číslo verze alterů v metasystému(MTS) , aby bylo možné k jednotlivým buildům přiřadit i zpětně odpovídající altery.
* Toto platí pro stávající verzi GI45.
* Do verze GI 47 můžete commitovat vše o čem si samozřejmě myslíte, že je plně funkční.:) Bude průběžně testována. 

## Pravidla pro programátory
* Práci začínám, když mám v TFS task.
* Když práci ukončím, **MUSÍM** vyplnit počet odpracovaných hodin do kolonky **Completed**.
* Do kolonky **Completed** nepíšu **100** jako 100%, ale skutečný počet odpracovaných hodin.
* Práci se snažím dokončit do data určeného v **Due Date**.
* Když nestíhám, řeším se zadavatelem. Buď mi posune **Due** nebo mě čeká noční.
* Na homepage ([Overview](http://XXX/_dashboards#activeDashboardId=1c8463d2-db9b-4315-8f08-e2e7c78a97d2)) je hned v levém horním rohu graf **My Items**. Tam naleznu všechny moje aktivní a odevzdané zadání a chyby.
* Pokouším se nejprve zpracovat všechny chyby, teprve pak jdu na další zadání. 

## Pravidla pro zadavatele
* Všechny nápady a náměty se zadávají jako **User Story**.
* Náměty se rozpracují na jednotlivé úkoly, **Task**y. Tyto Tasky musí být ve vazbě *child -> parent* k odpovídající User Story. 
* Úkoly se zadávají maximálně trvající 8h. Vyplní se do **Original Estimated**.
 