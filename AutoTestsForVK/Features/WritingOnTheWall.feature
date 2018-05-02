Feature: WritingOnTheWall


@mytag
Scenario: WritingOnTheWall
	Given Вводим логин и пароль "89998304592" "qazxswedcvfr"
	Then Проверка выполненного логина
	When Заходим друзья
	And  Находим друга "Александра Дмитриевна"
	And Заходим на страницу 
	And Находим и прикрепляем аудиозапись на стену "Бездыханным"
	And Отправить сообщение на стену
	And Ставим лайк


