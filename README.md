# TfsTools
Some TFS tools by FYK
## AlertsExplorer
Zobrazí seznam alertů. Původně možná per vybraný projekt, ale teď ... zobrazí všechno.
## AreasAndIterationsOnanyzer
Použil jsem kdysi na hromadnou aktualizaci Iterations and Areas. Teď bych to použil jen jako inspirace k dalším činům.
## Estimate2Remaining
Přesunuje hodnoty z "Original Estimate" do "Remaining Work". Zas, byla to jednorázová utilita, teď už jen pro vzpomínky.
## HtmlDescriptionMigrator
Přesunuje hodnoty z custom "HtmlDescription" fieldu do "Description". Použito jen při přechodu na TSF2015, protože dřív nebyl HTML description.
## TFS Management
Původní XML templates pro Task, Bug, Issue. Slouží pro inspiraci.
## TfsCleaner
Tohle je aktuálně jediný aktivní projekt. Mělo by to sloužit k automatizaci některých věcí kolem TFS, jako třeba když se změní stav, aby se item zaklidil do správný iterace.
Případně když se nastaví DueDate, aby se zařadil do správný iterace, pokud existuje. Operací si můžu vymyslet tunu, ale přidávám to tam postupně, abych nepřepálil start.
## TfsCommonControls
Společné vlastnosti pro TFS projekty. Nejpoužívanější je UO TfsUrlAndProjects, je tam taky Utils statická třída,
která vrací globální adresu pro TFS a poskytuje metodu pro vytvoření URL pro otevření editačního formu v prohližeči.
Pak tu je společné okno WIDetail, které zobrazí detail itemu.
## TfsWatcher
Pokusná aplikace, kde se učím jak s TFS. Původně jsem plánoval udělat aplikaci, co bude bydlet v systray a bude informovat o ... něčem ... ale nakonec to používám jen jako pomůcku, abych zjistil, jak se co udělá.
## WorkItemDestroyer
Když ještě TFS neumělo udělat delete itemu, bylo potřeba občas nějakej item odmajznout. A hle, toť aplikace, která to zvládá.
