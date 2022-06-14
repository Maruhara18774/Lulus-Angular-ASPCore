import { Designer } from "../model/Designer";

export class DesignerService{
    convertJSONtoListDesigner(body: any) {
        var result = new Array<Designer>();
        for (let i = 0; i < body.length; i++) {
            var item = new Designer(
                body[i].id,
                body[i].name,
                body[i].description,
                );
            result.push(item);
        }
        return result;
    }
}