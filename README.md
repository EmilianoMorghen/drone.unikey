# drone.unikey

## Abstract:
Il nostro cliente è un gestore di “flotte droni”, dal colloquio apprendiamo che: 
- I droni sono dei velivoli i cui voli sono monitorati e registrati; 
-	I voli sono autorizzati solo se all’interno dello span (intervallo ndr) di una missione; 
-	Un drone può partecipare a più voli a patto che il loro span temporale non sia coincidente o intersecante; 
-	Un drone per volare all’interno di una missione deve essere registrato alla missione; 
-	Un drone può partecipare a più missioni a patto che il loro span temporale non sia coincidente o intersecante; 

## Dominio Applicativo:
```
Missione { 
    Codice Identificativo 
    Data di inizio 
    Data di fine 
    Velivoli 
    Voli 
}
```
```
Volo { 
    Codice Identificativo 
    Data di inizio 
    Data di fine 
    Velivolo 
} 
```
```
Velivolo { 
    Codice Identificativo 
    Ore volate 
    Tipologia (valori assumibili: ala fissa, rotore) 
    Tipologia (valori assumibili: manned, unmanned) 
} 
```

## Goals:
Avendo l’elenco dei velivoli e delle missioni prepopolato, l’applicazione oggetto dello sviluppo dovrà, con le opportune validazioni:
- [ ] Permettere l’inserimento di un nuovo drone. 
- [ ] Permettere l’inserimento di un nuovo volo.
- [ ] Permettere di scegliere una missione e visualizzarne i dettagli. 

