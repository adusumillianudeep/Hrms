import { AvailableOnlyPipe } from './available-only.pipe';

describe('AvailableOnlyPipe', () => {
  it('create an instance', () => {
    const pipe = new AvailableOnlyPipe();
    expect(pipe).toBeTruthy();
  });
});
