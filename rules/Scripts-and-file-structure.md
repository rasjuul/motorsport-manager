# My scripts and file structure rules

I organize files by purpose and only create folders the project needs:

- `src/` for the C# game.
- `tests/` for meaningful automated tests when needed.
- `scripts/` for reusable development, verification, backup or upload scripts.
- `docs/` for project documentation and the project card.
- `docs/progress/` for dated task records.
- `docs/handoffs/` for dated pause and end-of-day hand-offs.
- `archive/` for clearly marked historical material when needed.

I save standalone code and helper scripts as files rather than leaving the only copy in chat. Routine read-only navigation commands do not need their own script files.

I use short English names describing purpose. Current scripts do not get dated duplicate filenames. Requested script changes are saved to the existing script, with Git preserving history. This does not authorize overwriting configuration files or running scripts against external systems.

Progress notes, hand-offs and separate backup snapshots retain dates. Changes to existing notes need my approval. I check file references and preserved content after an authorized move or rename and document the result.
