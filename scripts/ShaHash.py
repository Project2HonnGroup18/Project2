import hashlib
from pathlib import Path
from subprocess import Popen, check_output, PIPE
from os import remove, path

output_filename = "shasum.txt"
extensions = ["cs", "json", "csproj", "py"]

def get_byte_string(byte_list):
    string = ""
    for byte_val in byte_list:
        string += hex(byte_val)[2:]
    return string

if path.exists(output_filename):
    remove(output_filename)
    
for extension in extensions:
    findOutput = check_output(["find", ".", "-iname", "*." + extension])
    with open(output_filename, "a+") as file:
        hash = hashlib.sha256()
        hash.update(findOutput)

        file.write(extension + ": " + get_byte_string(hash.digest()) + " -\n")