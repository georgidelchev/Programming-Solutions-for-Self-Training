pet_patiance = 10
pet_health = 10
pet_rest = 10
pet_IQ = 0

commands_left = 10

def train(command)
    if commnad == "sit":
        pet_IQ = pet_IQ + 5
        pet_patiance = pet_patiance - 5
        pet_health = pet_health - 1
        pet_rest = pet_rest - 3
    
    if command == "play dead":
        pet_IQ = pet_IQ + 3
        pet_patiance = pet_patiance - 3
        pet_health = pet_health - 5
        pet_rest = pet_rest - 1

    if command == "eat":
        pet_IQ = pet_IQ - 1
        pet_patiance = pet_patiance + 5
        pet_health = pet_health + 5
        pet_rest = pet_rest - 1

    if command == "rest":
        pet_IQ = pet_IQ + 5
        pet_patiance = pet_patiance - 5
        pet_health = pet_health - 1
        pet_rest = pet_rest - 3

while True:
    commands_left = commands_left - 1
    if commands_left == 0:
        break
    if pet_patiance == 0:
        print("Your pet left")
        break
    if pet_health == 0:
        print("Your pet dead")
        break
    if pet_rest == 0:
        print("Your pet sleep")
        break
    if pet_IQ >= 15:
        print("Your pet is smart")
        break

    command = input("> ")
    if command == "help":
        print("Commands: sit, play dead, eat, rest")
    else:
        train(command)




