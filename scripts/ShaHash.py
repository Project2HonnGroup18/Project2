from subprocess import Popen, check_output, PIPE
from os import remove

output_filename = "shasum.txt"
extensions = ["cs", "json", "csproj", "py"]

remove(output_filename)
for extension in extensions:
    findOutput = check_output(["find", "../", "-iname", "*." + extension])
    #findOutput = findProcess.stdout.decode("utf-8")
    with open(output_filename, "a+") as file:
        shaProcess = Popen(["shasum", "-a", "256"], stdin=PIPE, stdout=PIPE, shell=True)
        hash, _ = shaProcess.communicate(findOutput, 5)
        file.write(extension + ": " + hash.decode("utf-8"))