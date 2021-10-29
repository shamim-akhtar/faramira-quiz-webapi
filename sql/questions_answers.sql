BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('The children like going on learning journeys, _______ they?', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'do'),
		(@last_q_id, 1, 'don''t'),
		(@last_q_id, 0, 'have'),
		(@last_q_id, 0, 'haven''t');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('“I’m afraid I cannot process your payment using a credit card, Sir. The shop only accepts payment _______ cash,” said the cashier.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 1, 'by'),
		(@last_q_id, 0, 'in'),
		(@last_q_id, 0, 'on'),
		(@last_q_id, 0, 'through');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Andika _______ the movie after he has read the book.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'understand'),
		(@last_q_id, 0, 'understood'),
		(@last_q_id, 1, 'understands'),
		(@last_q_id, 0, 'had understood');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Ashikin is one of those people who _______ best under pressure.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'work'),
		(@last_q_id, 1, 'works'),
		(@last_q_id, 0, 'worked'),
		(@last_q_id, 0, 'working');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Mrs Foo made Kenneth _______ his untidy handwriting before allowing him to proceed with the next question.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 1, 'erase'),
		(@last_q_id, 0, 'erases'),
		(@last_q_id, 0, 'erased'),
		(@last_q_id, 0, 'erasing');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('A swarm of locusts usually _______ an entire field of crops within a short span of time.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 1, 'destroy'),
		(@last_q_id, 0, 'destroys'),
		(@last_q_id, 0, 'destroyed'),
		(@last_q_id, 0, 'destroying');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Mdm Moliah, our principal, reminded us to walk and not run _______ the corridors in the school.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'by'),
		(@last_q_id, 0, 'across'),
		(@last_q_id, 1, 'along'),
		(@last_q_id, 0, 'over');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('_______ you are accompanying Andrew, I will allow him to go to the party. He is too young to go on his own.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 1, 'Since'),
		(@last_q_id, 0, 'Unless'),
		(@last_q_id, 0, 'Despite'),
		(@last_q_id, 0, 'Although');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('If I _______ you, I would look for a new home immediately.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'am'),
		(@last_q_id, 0, 'are'),
		(@last_q_id, 0, 'was'),
		(@last_q_id, 1, 'were');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('The audience almost went wild when the popular superstar _______ onto the stage.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'sashay'),
		(@last_q_id, 0, 'sashays'),
		(@last_q_id, 1, 'sashayed'),
		(@last_q_id, 0, 'has sashayed');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Living in a multi-cultural country like ours, we ought to learn to be more tolerant _______ various religious practices.
', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 1, 'of'),
		(@last_q_id, 0, 'to'),
		(@last_q_id, 0, 'about'),
		(@last_q_id, 0, 'with');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Jason refused to turn up for the seminar _______ Yi Hua was coming along. They had agreed to participate in the sessions together. ', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'since'),
		(@last_q_id, 1, 'unless'),
		(@last_q_id, 0, 'because'),
		(@last_q_id, 0, 'although');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('Neither the team members nor their group leader _______ yet. They will be late for the competition if they are not here in fifteen minutes.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'arrives'),
		(@last_q_id, 0, 'arrived'),
		(@last_q_id, 1, 'has arrived'),
		(@last_q_id, 0, 'have arrived');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('I am aware of the issue, _______ I?', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'am'),
		(@last_q_id, 0, 'isn''t'),
		(@last_q_id, 1, 'aren''t'),
		(@last_q_id, 0, 'shan''t');
COMMIT;

BEGIN;
	INSERT INTO quiz.questions (question, is_active) VALUES('The burglar _______ made with some computer hardware at the main office before the police arrived.', 1);
	SELECT LAST_INSERT_ID() INTO @last_q_id;
	INSERT INTO quiz.question_choices (question_id, is_right_choice, choice) VALUES
		(@last_q_id, 0, 'in'),
		(@last_q_id, 0, 'up'),
		(@last_q_id, 1, 'off'),
		(@last_q_id, 0, 'over');
COMMIT;