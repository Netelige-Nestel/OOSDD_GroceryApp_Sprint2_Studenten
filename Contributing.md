## Gitflow Documentatie

Onze branching strategie maakt gebruik van meerdere branches.

Main:

- De main branch bewaart de hoofdversies van de repository.
- Alle aanpassingen aan de main branch moeten met een pull request worden goedgekeurd.
- Releases worden altijd vanaf de main branch gemaakt.

Development:

- Vanaf development worden feature branches gemaakt.

Feature:

- Nieuwe functionaliteiten worden vanaf feature branches gemaakt.
- Feature branches mergen met Development, niet met main.
- Feature branches worden na gebruik verwijderd.

Hotfix:
	
- Hotfix branches worden vanaf main gemaakt.
- Gebruik hotfix branches voor snelle bugfixes aan main.
- Hotfix branches worden na gebruik verwijderd.