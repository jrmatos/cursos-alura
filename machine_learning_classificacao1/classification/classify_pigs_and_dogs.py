from sklearn.naive_bayes import MultinomialNB

# fat? short leg? barks?
pig1 = [1, 1, 0]
pig2 = [1, 1, 0]
pig3 = [1, 1, 0]
dog1 = [1, 1, 1]
dog2 = [0, 1, 1]
dog3 = [0, 1, 1]

dataset = [pig1, pig1, pig3, dog1, dog2, dog3]

# 1 = pig, -1 = dog
demarcation = [1, 1, 1, -1, -1, -1]

model = MultinomialNB()
model.fit(dataset, demarcation)

# guys to predict
mysterious1 = [1, 1, 1]
mysterious2 = [1, 0, 0]
mysterious3 = [0, 0, 1]

# group of guys to predict
tests = [mysterious1, mysterious2, mysterious3]

# expected result [dog, pig, dog]
demarcation_test = [-1, 1, 1]

# predict it
result = model.predict(tests)

differences = result - demarcation_test

hits = [d for d in differences if d == 0]

total_hits = len(hits)
total_elements = len(tests)
hit_rate = 100.0 * total_hits / total_elements

print(str(total_hits) + " succesful predictions from " + str(total_elements) + " elements (" + str(hit_rate) + "%)")