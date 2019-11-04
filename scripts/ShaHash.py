from subprocess import Popen, check_output, PIPE
from os import remove, path

output_filename = "shasum.txt"
extensions = ["cs", "json", "csproj", "py"]

if path.exists(output_filename):
    remove(output_filename)
    
for extension in extensions:
    findOutput = check_output(["find", "../", "-iname", "*." + extension])
    with open(output_filename, "a+") as file:
        shaProcess = Popen(["shasum", "-a", "256"], stdin=PIPE, stdout=PIPE, shell=True)
        hash, _ = shaProcess.communicate(findOutput, 5)
        file.write(extension + ": " + hash.decode("utf-8"))