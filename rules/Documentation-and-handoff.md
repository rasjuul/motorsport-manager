# My documentation and hand-off rules

After each completed task, I keep a new dated note in `docs/progress/` with the task, changes and reasons, relevant files, sources, decisions, checks and results, outstanding work and next steps.

I separate planned, implemented, documented, tested and live-verified work. I only record checks that were actually performed. Notes and uploads use English and my first-person voice.

When I pause or stop for the day, I keep a new dated note in `docs/handoffs/` covering purpose and status, completed and unfinished work, relevant files and commits, test results, unverified behavior, decisions, blockers, next steps and local changes awaiting upload.

Before resuming, I read the latest hand-off. If none exists, I state that before reconstructing status from the conversation.

At a pause or the end of the day, I back up the project source, relevant save files and hand-off to a separate project folder in my private backup location. I exclude build output, repository internals and credentials. I preserve previous backups and follow that repository's rules. I verify the copied files and distinguish local backup completion from a verified GitHub upload.

Before any upload, I review the exact files, destination, visibility and approval scope, and check for private data and secrets. I verify that the commit reached the intended remote. If upload is blocked, I retain the local files and record the reason. I never publish secrets in this public repository.

Existing notes require my approval before changes. Existing configurations must never be overwritten.
