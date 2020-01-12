import { Injectable } from "@angular/core";
import {
  ToasterService,
  ToasterConfig,
  Toast,
  BodyOutputType
} from "angular2-toaster";

@Injectable({
  providedIn: "root"
})
export class NotificationService {
  constructor(private toasterService: ToasterService) {}

  position = "toast--top-center";
  animationType = "fade";
  title = "HI there!";
  content = `I'm cool toaster!`;
  timeout = 5000;
  toastsLimit = 5;
  type = "default";

  isNewestOnTop = true;
  isHideOnClick = true;
  isDuplicatesPrevented = false;
  isCloseButton = true;

  config = new ToasterConfig({
    timeout: this.timeout,
    newestOnTop: this.isNewestOnTop,
    tapToDismiss: this.isHideOnClick,
    positionClass: this.position,
    preventDuplicates: this.isDuplicatesPrevented,
    animation: this.animationType,
    limit: this.toastsLimit,
    showCloseButton: false
  });

  public getConfig() {
    return this.config;
  }

  /**
   * notifikace success
   *
   * @param message
   * @param type
   */
  public success(message: string, type: any = null) {
    this.show("success", message, "");
  }

  /**
   * notifikace error
   *
   * @param message
   * @param type
   */
  public error(message: string, type: any = null) {
    if (type == "list") {
      for (let i = 0; i < message.length; i++) {
        this.show("error", message[i], "");
      }
    } else {
      this.show("error", message, "");
    }
  }

  /**
   * zobrazeni notifikace
   *
   * @param type
   * @param title
   * @param body
   */
  public show(type: string, title: string, body: string) {
    const toast: Toast = {
      type: type,
      title: title,
      body: body,
      timeout: this.timeout,
      showCloseButton: this.isCloseButton,
      bodyOutputType: BodyOutputType.TrustedHtml
    };

    this.toasterService.popAsync(toast);
  }
}
