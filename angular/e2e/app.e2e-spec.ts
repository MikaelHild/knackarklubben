import { AmmStewTemplatePage } from './app.po';

describe('AmmStew App', function() {
  let page: AmmStewTemplatePage;

  beforeEach(() => {
    page = new AmmStewTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
