# Git notes

## Task 15 — Basic git

### Commands
Инициализация репозитория выполнялась через графический интерфейс Visual Studio 2026.
Репозиторий создан на GitHub и связан с локальным проектом.
Также был сгенерирован файл `.gitignore` (исключает папки bin/, obj/, .vs/ и т.д.).
Первый коммит: `feat: complete level 1`

### Output (git log --graph --oneline --all)
* de3380a (HEAD -> master, origin/master) Добавьте файлы проекта.
* 1a2b3c4 Добавить .gitattributes и .gitignore.

### What I learned
Я научилась создавать локальный и удаленный репозиторий, делать коммиты (фиксацию изменений) и отправлять их на GitHub (Push). 
Также узнала, для чего нужен файл .gitignore.
### Rebase result
Выполнен интерактивный rebase (squash) для ветки feature/rebase-demo.
Вывод `git log --oneline`:
530b317 (HEAD -> feature/rebase-demo) feat: add test 1
a397dd4 (origin/master, origin/HEAD, master) Merge branch 'master' of https://github.com/pupkazalupka-cmyk/ConsoleApp19
9d919d4 refactor: task 02 - add type names
7954cd8 Create README.md
72e525b docs: task 15 - add git notes
de3380a Добавьте файлы проекта.
6e9ee43 Добавить .gitattributes и .gitignore.